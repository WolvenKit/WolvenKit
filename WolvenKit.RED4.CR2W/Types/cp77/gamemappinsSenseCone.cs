using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsSenseCone : CVariable
	{
		private CFloat _length;
		private CFloat _width;
		private CFloat _angleDegrees;
		private Vector4 _position1;
		private Vector4 _position2;

		[Ordinal(0)] 
		[RED("length")] 
		public CFloat Length
		{
			get => GetProperty(ref _length);
			set => SetProperty(ref _length, value);
		}

		[Ordinal(1)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(2)] 
		[RED("angleDegrees")] 
		public CFloat AngleDegrees
		{
			get => GetProperty(ref _angleDegrees);
			set => SetProperty(ref _angleDegrees, value);
		}

		[Ordinal(3)] 
		[RED("position1")] 
		public Vector4 Position1
		{
			get => GetProperty(ref _position1);
			set => SetProperty(ref _position1, value);
		}

		[Ordinal(4)] 
		[RED("position2")] 
		public Vector4 Position2
		{
			get => GetProperty(ref _position2);
			set => SetProperty(ref _position2, value);
		}

		public gamemappinsSenseCone(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
