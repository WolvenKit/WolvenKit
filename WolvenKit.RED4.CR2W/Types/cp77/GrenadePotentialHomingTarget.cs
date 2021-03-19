using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrenadePotentialHomingTarget : CVariable
	{
		private wCHandle<ScriptedPuppet> _entity;
		private CName _targetSlot;

		[Ordinal(0)] 
		[RED("entity")] 
		public wCHandle<ScriptedPuppet> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(1)] 
		[RED("targetSlot")] 
		public CName TargetSlot
		{
			get => GetProperty(ref _targetSlot);
			set => SetProperty(ref _targetSlot, value);
		}

		public GrenadePotentialHomingTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
