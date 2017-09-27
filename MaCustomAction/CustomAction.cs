using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Deployment.WindowsInstaller;

namespace MaCustomAction
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult DeferredHello(Session session)
        {
            session.Log("Begin DeferredHello");

            CustomActionData data = session.CustomActionData;

            session.Log($"Hello { data["Name"] }");

            return ActionResult.Success;
        }
    }
}
