using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConstantStatPoolPrereqState : StatPoolPrereqState
	{
		[Ordinal(1)] 
		[RED("listenConstantly")] 
		public CBool ListenConstantly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}
	}
}
