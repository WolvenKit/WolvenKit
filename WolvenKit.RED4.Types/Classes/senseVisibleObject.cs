using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseVisibleObject : IScriptable
	{
		private CName _description;
		private CFloat _visibilityDistance;
		private CEnum<gamedataSenseObjectType> _visibleObjectType;

		[Ordinal(0)] 
		[RED("description")] 
		public CName Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(1)] 
		[RED("visibilityDistance")] 
		public CFloat VisibilityDistance
		{
			get => GetProperty(ref _visibilityDistance);
			set => SetProperty(ref _visibilityDistance, value);
		}

		[Ordinal(2)] 
		[RED("visibleObjectType")] 
		public CEnum<gamedataSenseObjectType> VisibleObjectType
		{
			get => GetProperty(ref _visibleObjectType);
			set => SetProperty(ref _visibleObjectType, value);
		}
	}
}
