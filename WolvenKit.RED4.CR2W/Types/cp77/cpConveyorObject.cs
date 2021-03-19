using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpConveyorObject : gameObject
	{
		private CFloat _rotationLerpFactor;
		private CBool _ignoreZAxis;

		[Ordinal(40)] 
		[RED("rotationLerpFactor")] 
		public CFloat RotationLerpFactor
		{
			get => GetProperty(ref _rotationLerpFactor);
			set => SetProperty(ref _rotationLerpFactor, value);
		}

		[Ordinal(41)] 
		[RED("ignoreZAxis")] 
		public CBool IgnoreZAxis
		{
			get => GetProperty(ref _ignoreZAxis);
			set => SetProperty(ref _ignoreZAxis, value);
		}

		public cpConveyorObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
