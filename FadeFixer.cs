using ScriptPortal.Vegas;

namespace FadeFixer
{
    public class EntryPoint
    {
        public void FromVegas(Vegas vegas)
        {
            foreach (Track t in vegas.Project.Tracks)
            {
                foreach (TrackEvent evt in t.Events)
                {
                    if (evt.Start > Timecode.FromSeconds(0))
                    {
                        evt.FadeIn.Length = Timecode.FromSeconds(1);
                    }
                    evt.FadeOut.Length = Timecode.FromSeconds(1);
                }
            }
        }
    }
}

