using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workAnimClip : workIEntry
	{
		private CName _animName;
		private CFloat _blendOutTime;

		[Ordinal(2)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}

		[Ordinal(3)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get => GetProperty(ref _blendOutTime);
			set => SetProperty(ref _blendOutTime, value);
		}

		public workAnimClip(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
