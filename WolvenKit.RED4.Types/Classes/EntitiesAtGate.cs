using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EntitiesAtGate : MorphData
	{
		private CArray<entEntityID> _entitiesAtGate;

		[Ordinal(1)] 
		[RED("entitiesAtGate")] 
		public CArray<entEntityID> EntitiesAtGate_
		{
			get => GetProperty(ref _entitiesAtGate);
			set => SetProperty(ref _entitiesAtGate, value);
		}
	}
}
