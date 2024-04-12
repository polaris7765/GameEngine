using AppLogic;
using EFFramework;
using UnityEngine;
using UnityEngine.UIElements;

public class EntityPlayer : MonoBehaviour
{	
	public RoomBoundary Boundary;
	public float MoveSpeed = 10f;
	public float FireRate = 0.25f;

	private float _nextFireTime = 0f;
	private Transform _shotSpawn;
	private Rigidbody _rigidbody;
	private AudioSource _audioSource;

	void Awake()
	{
		_rigidbody = this.gameObject.GetComponent<Rigidbody>();
		_audioSource = this.gameObject.GetComponent<AudioSource>();
		_shotSpawn = this.transform.Find("shot_spawn");
	}
	void Update()
	{
		if (Input.GetButton("Fire1") && Time.time > _nextFireTime)
		{
			_nextFireTime = Time.time + FireRate;
			_audioSource.Play();
			AppEvent.Send(ActorEventDefine.PlayerFireBullet,_shotSpawn.position, _shotSpawn.rotation);
		}
	}

	private float halfScreenWidth = Screen.width / 2 * 1.0f;
	private float halfScreenHeight = Screen.height / 2 * 1.0f;
	
	void FixedUpdate()
	{
#if UNITY_IOS || UNITY_ANDROID
		float moveHorizontal = 0;
		float moveVertical = 0;
		if (Input.GetButton("Fire1"))
		{
			// 获取鼠标位置
			Vector2 mouseScreenPosition = Input.mousePosition;
            moveHorizontal = (mouseScreenPosition.x - halfScreenWidth) / halfScreenWidth * 1.0f;
			moveVertical = (mouseScreenPosition.y - halfScreenHeight) / halfScreenHeight * 1.0f;
			//Debug.Log($"mouseScreenPosition:{mouseScreenPosition}, {moveHorizontal},{moveVertical}");
		}
		
#else
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
#endif
		

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		_rigidbody.velocity = movement * MoveSpeed;
		_rigidbody.position = new Vector3
		(
			Mathf.Clamp(GetComponent<Rigidbody>().position.x, Boundary.xMin, Boundary.xMax),
			0.0f,
			Mathf.Clamp(GetComponent<Rigidbody>().position.z, Boundary.zMin, Boundary.zMax)
		);

		float tilt = 5f;
		_rigidbody.rotation = Quaternion.Euler(0.0f, 0.0f, _rigidbody.velocity.x * -tilt);
	}
	void OnTriggerEnter(Collider other)
	{
		var name = other.gameObject.name;
		if (name.StartsWith("enemy") || name.StartsWith("asteroid"))
		{
			AppEvent.Send(ActorEventDefine.PlayerDead,transform.position, transform.rotation);
			PoolManager.Instance.PushGameObject(this.gameObject);
		}
	}
}