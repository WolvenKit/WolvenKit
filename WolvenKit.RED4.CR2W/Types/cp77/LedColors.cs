using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LedColors : CVariable
	{
		private ScriptLightSettings _off;
		private ScriptLightSettings _red;
		private ScriptLightSettings _green;

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

		public LedColors(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
