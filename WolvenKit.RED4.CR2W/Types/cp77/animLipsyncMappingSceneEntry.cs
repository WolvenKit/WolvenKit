using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLipsyncMappingSceneEntry : CVariable
	{
		private CArray<CRUID> _actorVoiceTags;
		private CArray<raRef<animAnimSet>> _animSets;

		[Ordinal(0)] 
		[RED("actorVoiceTags")] 
		public CArray<CRUID> ActorVoiceTags
		{
			get
			{
				if (_actorVoiceTags == null)
				{
					_actorVoiceTags = (CArray<CRUID>) CR2WTypeManager.Create("array:CRUID", "actorVoiceTags", cr2w, this);
				}
				return _actorVoiceTags;
			}
			set
			{
				if (_actorVoiceTags == value)
				{
					return;
				}
				_actorVoiceTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animSets")] 
		public CArray<raRef<animAnimSet>> AnimSets
		{
			get
			{
				if (_animSets == null)
				{
					_animSets = (CArray<raRef<animAnimSet>>) CR2WTypeManager.Create("array:raRef:animAnimSet", "animSets", cr2w, this);
				}
				return _animSets;
			}
			set
			{
				if (_animSets == value)
				{
					return;
				}
				_animSets = value;
				PropertySet(this);
			}
		}

		public animLipsyncMappingSceneEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
