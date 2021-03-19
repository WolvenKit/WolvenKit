using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRainEvent : redEvent
	{
		private CEnum<worldRainIntensity> _rainIntensity;

		[Ordinal(0)] 
		[RED("rainIntensity")] 
		public CEnum<worldRainIntensity> RainIntensity
		{
			get => GetProperty(ref _rainIntensity);
			set => SetProperty(ref _rainIntensity, value);
		}

		public worldRainEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
