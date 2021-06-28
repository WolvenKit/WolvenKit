using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DismembermentDebrisEvent : redEvent
	{
		private CString _resourcePath;
		private CFloat _strength;

		[Ordinal(0)] 
		[RED("resourcePath")] 
		public CString ResourcePath
		{
			get => GetProperty(ref _resourcePath);
			set => SetProperty(ref _resourcePath, value);
		}

		[Ordinal(1)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetProperty(ref _strength);
			set => SetProperty(ref _strength, value);
		}

		public DismembermentDebrisEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
