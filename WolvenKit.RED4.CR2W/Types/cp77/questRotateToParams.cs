using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRotateToParams : questAICommandParams
	{
		private CHandle<questUniversalRef> _facingTargetRef;
		private CFloat _angleOffset;
		private CFloat _speed;

		[Ordinal(0)] 
		[RED("facingTargetRef")] 
		public CHandle<questUniversalRef> FacingTargetRef
		{
			get => GetProperty(ref _facingTargetRef);
			set => SetProperty(ref _facingTargetRef, value);
		}

		[Ordinal(1)] 
		[RED("angleOffset")] 
		public CFloat AngleOffset
		{
			get => GetProperty(ref _angleOffset);
			set => SetProperty(ref _angleOffset, value);
		}

		[Ordinal(2)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		public questRotateToParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
