using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitIsMovingPrereq : GenericHitPrereq
	{
		[Ordinal(8)] 
		[RED("isMoving")] 
		public CBool IsMoving
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("object")] 
		public CString Object
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public HitIsMovingPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
