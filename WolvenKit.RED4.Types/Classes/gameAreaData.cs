using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAreaData : RedBaseClass
	{
		private Vector4 _position;
		private CFloat _size;
		private CEnum<gameEAreaType> _type;
		private CEnum<gameEAreaShape> _shape;
		private CName _name;
		private CUInt32 _priority;
		private TweakDBID _lootID;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(1)] 
		[RED("size")] 
		public CFloat Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<gameEAreaType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(3)] 
		[RED("shape")] 
		public CEnum<gameEAreaShape> Shape
		{
			get => GetProperty(ref _shape);
			set => SetProperty(ref _shape, value);
		}

		[Ordinal(4)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(5)] 
		[RED("priority")] 
		public CUInt32 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(6)] 
		[RED("lootID")] 
		public TweakDBID LootID
		{
			get => GetProperty(ref _lootID);
			set => SetProperty(ref _lootID, value);
		}

		public gameAreaData()
		{
			_size = 1.000000F;
		}
	}
}
