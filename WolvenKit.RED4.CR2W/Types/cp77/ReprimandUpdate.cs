using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReprimandUpdate : redEvent
	{
		private CEnum<EReprimandInstructions> _reprimandInstructions;
		private entEntityID _target;
		private Vector4 _targetPos;
		private wCHandle<gameObject> _currentPerformer;

		[Ordinal(0)] 
		[RED("reprimandInstructions")] 
		public CEnum<EReprimandInstructions> ReprimandInstructions
		{
			get => GetProperty(ref _reprimandInstructions);
			set => SetProperty(ref _reprimandInstructions, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public entEntityID Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("targetPos")] 
		public Vector4 TargetPos
		{
			get => GetProperty(ref _targetPos);
			set => SetProperty(ref _targetPos, value);
		}

		[Ordinal(3)] 
		[RED("currentPerformer")] 
		public wCHandle<gameObject> CurrentPerformer
		{
			get => GetProperty(ref _currentPerformer);
			set => SetProperty(ref _currentPerformer, value);
		}

		public ReprimandUpdate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
