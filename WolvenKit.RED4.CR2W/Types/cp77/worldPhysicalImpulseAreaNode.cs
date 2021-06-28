using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPhysicalImpulseAreaNode : worldPhysicalTriggerAreaNode
	{
		private Vector3 _impulse;
		private CFloat _impulseRadius;

		[Ordinal(7)] 
		[RED("impulse")] 
		public Vector3 Impulse
		{
			get => GetProperty(ref _impulse);
			set => SetProperty(ref _impulse, value);
		}

		[Ordinal(8)] 
		[RED("impulseRadius")] 
		public CFloat ImpulseRadius
		{
			get => GetProperty(ref _impulseRadius);
			set => SetProperty(ref _impulseRadius, value);
		}

		public worldPhysicalImpulseAreaNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
