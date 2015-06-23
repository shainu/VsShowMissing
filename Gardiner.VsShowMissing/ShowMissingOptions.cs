using System.ComponentModel;
using Microsoft.VisualStudio.Shell;

namespace DavidGardiner.Gardiner_VsShowMissing
{
    [Description("Extension that checks for any files referenced in projects that do not exist")]
    [LocDisplayName("Extension that checks for any files referenced in projects that do not exist")]
    public class ShowMissingOptions : DialogPage
    {
        [LocDisplayName("Message importance")]
        [Description("What kind of message to create in the Error List window for each missing file")]
        [Category("Show Missing")]
        [DefaultValue(TaskErrorCategory.Error)]
        public TaskErrorCategory MessageLevel { get; set; }

        [LocDisplayName("Cancel build on error")]
        [Description("If true, cancel the build if any missing files are found. This only has effect if When is set to BeforeBuild")]
        [Category("Show Missing")]
        [DefaultValue(false)]
        public bool FailBuildOnError { get; set; }

        [LocDisplayName("When")]
        [Description("When to check for missing files")]
        [Category("Show Missing")]
        [DefaultValue(RunWhen.BeforeBuild)]
        public RunWhen Timing { get; set; }
    }
}