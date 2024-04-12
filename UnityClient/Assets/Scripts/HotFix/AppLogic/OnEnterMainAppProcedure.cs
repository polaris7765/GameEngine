using EFFramework;

namespace AppLogic
{
    public class OnEnterMainAppProcedure : ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Log.Debug("OnEnter MainApp Procedure");
        }
    }
}