using EFFramework;

namespace AppLogic
{
    public class OnEnterMainAppProcedure : ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);
            EFLogger.Debug("OnEnter MainApp Procedure");
        }
    }
}