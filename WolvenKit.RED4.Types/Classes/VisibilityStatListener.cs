using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VisibilityStatListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}
	}
}
