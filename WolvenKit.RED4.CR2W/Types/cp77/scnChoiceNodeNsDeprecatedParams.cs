using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsDeprecatedParams : CVariable
	{
		private scnActorId _actorId;
		private scnPropId _propId;

		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get
			{
				if (_actorId == null)
				{
					_actorId = (scnActorId) CR2WTypeManager.Create("scnActorId", "actorId", cr2w, this);
				}
				return _actorId;
			}
			set
			{
				if (_actorId == value)
				{
					return;
				}
				_actorId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get
			{
				if (_propId == null)
				{
					_propId = (scnPropId) CR2WTypeManager.Create("scnPropId", "propId", cr2w, this);
				}
				return _propId;
			}
			set
			{
				if (_propId == value)
				{
					return;
				}
				_propId = value;
				PropertySet(this);
			}
		}

		public scnChoiceNodeNsDeprecatedParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
