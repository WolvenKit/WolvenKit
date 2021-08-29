using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class KillTaggedTargetEvent : redEvent
	{
		private CWeakHandle<gameObject> _taggedObject;

		[Ordinal(0)] 
		[RED("taggedObject")] 
		public CWeakHandle<gameObject> TaggedObject
		{
			get => GetProperty(ref _taggedObject);
			set => SetProperty(ref _taggedObject, value);
		}
	}
}
