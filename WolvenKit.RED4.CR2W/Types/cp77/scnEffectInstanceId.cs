using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnEffectInstanceId : CVariable
	{
		private scnEffectId _effectId;
		private CUInt32 _id;

		[Ordinal(0)] 
		[RED("effectId")] 
		public scnEffectId EffectId
		{
			get => GetProperty(ref _effectId);
			set => SetProperty(ref _effectId, value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public scnEffectInstanceId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
