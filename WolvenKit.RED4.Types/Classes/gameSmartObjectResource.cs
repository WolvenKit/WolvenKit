using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectResource : CResource
	{
		private CArray<gameSmartObjectGate> _entryPoints;
		private CArray<gameSmartObjectGate> _exitPoints;
		private CArray<gameBodyTypeAnimationDefinition> _bodyTypes;
		private CArray<gameSmartObjectGate> _loopAnimations;
		private CEnum<gameSmartObjectType> _type;

		[Ordinal(1)] 
		[RED("entryPoints")] 
		public CArray<gameSmartObjectGate> EntryPoints
		{
			get => GetProperty(ref _entryPoints);
			set => SetProperty(ref _entryPoints, value);
		}

		[Ordinal(2)] 
		[RED("exitPoints")] 
		public CArray<gameSmartObjectGate> ExitPoints
		{
			get => GetProperty(ref _exitPoints);
			set => SetProperty(ref _exitPoints, value);
		}

		[Ordinal(3)] 
		[RED("bodyTypes")] 
		public CArray<gameBodyTypeAnimationDefinition> BodyTypes
		{
			get => GetProperty(ref _bodyTypes);
			set => SetProperty(ref _bodyTypes, value);
		}

		[Ordinal(4)] 
		[RED("loopAnimations")] 
		public CArray<gameSmartObjectGate> LoopAnimations
		{
			get => GetProperty(ref _loopAnimations);
			set => SetProperty(ref _loopAnimations, value);
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<gameSmartObjectType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
