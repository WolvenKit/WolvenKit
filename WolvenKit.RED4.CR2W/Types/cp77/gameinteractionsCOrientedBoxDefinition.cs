using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCOrientedBoxDefinition : gameinteractionsIShapeDefinition
	{
		private Vector4 _position;
		private Vector4 _forward;
		private Vector4 _right;
		private Vector4 _up;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(1)] 
		[RED("forward")] 
		public Vector4 Forward
		{
			get => GetProperty(ref _forward);
			set => SetProperty(ref _forward, value);
		}

		[Ordinal(2)] 
		[RED("right")] 
		public Vector4 Right
		{
			get => GetProperty(ref _right);
			set => SetProperty(ref _right, value);
		}

		[Ordinal(3)] 
		[RED("up")] 
		public Vector4 Up
		{
			get => GetProperty(ref _up);
			set => SetProperty(ref _up, value);
		}

		public gameinteractionsCOrientedBoxDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
