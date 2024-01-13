namespace VivatInternship.Backend.Authorization
{
     [AttributeUsage(AttributeTargets.Method)]
     public class AllowAnonymousAttribute : Attribute
     {
          //It's used in the users controller to allow anonymous access to the register and login action methods. The custom authorize attribute below skips authorization if the action method is decorated with [AllowAnonymous].

     }
}
