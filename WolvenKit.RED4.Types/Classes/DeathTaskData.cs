using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeathTaskData : gameScriptTaskData
	{
		[Ordinal(0)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}
	}
}
