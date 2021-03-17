using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LedColors_SensorDevice : CVariable
	{
		private ScriptLightSettings _off;
		private ScriptLightSettings _red;
		private ScriptLightSettings _green;
		private ScriptLightSettings _blue;
		private ScriptLightSettings _yellow;
		private ScriptLightSettings _white;

		[Ordinal(0)] 
		[RED("off")] 
		public ScriptLightSettings Off
		{
			get => GetProperty(ref _off);
			set => SetProperty(ref _off, value);
		}

		[Ordinal(1)] 
		[RED("red")] 
		public ScriptLightSettings Red
		{
			get => GetProperty(ref _red);
			set => SetProperty(ref _red, value);
		}

		[Ordinal(2)] 
		[RED("green")] 
		public ScriptLightSettings Green
		{
			get => GetProperty(ref _green);
			set => SetProperty(ref _green, value);
		}

		[Ordinal(3)] 
		[RED("blue")] 
		public ScriptLightSettings Blue
		{
			get => GetProperty(ref _blue);
			set => SetProperty(ref _blue, value);
		}

		[Ordinal(4)] 
		[RED("yellow")] 
		public ScriptLightSettings Yellow
		{
			get => GetProperty(ref _yellow);
			set => SetProperty(ref _yellow, value);
		}

		[Ordinal(5)] 
		[RED("white")] 
		public ScriptLightSettings White
		{
			get => GetProperty(ref _white);
			set => SetProperty(ref _white, value);
		}

		public LedColors_SensorDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
