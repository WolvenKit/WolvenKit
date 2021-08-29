using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_LookAtApplyVehicleRestrictions : animAnimNode_OnePoseInput
	{
		private CName _group;
		private CName _name;
		private animTransformIndex _referenceBone;

		[Ordinal(12)] 
		[RED("group")] 
		public CName Group
		{
			get => GetProperty(ref _group);
			set => SetProperty(ref _group, value);
		}

		[Ordinal(13)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(14)] 
		[RED("referenceBone")] 
		public animTransformIndex ReferenceBone
		{
			get => GetProperty(ref _referenceBone);
			set => SetProperty(ref _referenceBone, value);
		}
	}
}
