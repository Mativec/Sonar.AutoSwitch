using Avalonia.Platform;

namespace Sonar.AutoSwitch.Services
{
    public class MonitorOption
    {
        public string Name { get; }
        public Screen? Screen { get; }

        public MonitorOption(string name, Screen? screen)
        {
            Name = name;
            Screen = screen;
        }

        public override string ToString() => Name;
    }

}
