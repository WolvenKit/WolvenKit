using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsTraceResult : CVariable
	{
		private Vector3 _position;
		private Vector3 _normal;
		private CName _material;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(1)] 
		[RED("normal")] 
		public Vector3 Normal
		{
			get => GetProperty(ref _normal);
			set => SetProperty(ref _normal, value);
		}

		[Ordinal(2)] 
		[RED("material")] 
		public CName Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}

		public physicsTraceResult(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
