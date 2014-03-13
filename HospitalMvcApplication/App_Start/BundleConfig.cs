using System.Web;
using System.Web.Optimization;

namespace HospitalMvcApplication
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.*")
                        .Include("~/Scripts/script.js"));


            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap*"));

            bundles.Add(new StyleBundle("~/Content/css")
                    .Include("~/Content/site.css")
                    .Include("~/Content/base.css")/* правильний порядок */
                    .Include("~/Content/bootstrap*"));
        }
    }

}