using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProcessQueuedCombatExperience : gamePlayerScriptableSystemRequest
	{
		private entEntityID _entity;

		[Ordinal(1)] 
		[RED("entity")] 
		public entEntityID Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		public ProcessQueuedCombatExperience(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
