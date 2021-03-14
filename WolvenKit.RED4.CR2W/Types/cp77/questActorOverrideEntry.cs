using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questActorOverrideEntry : CVariable
	{
		private CName _metadataForOverride;
		private CName _actorName;

		[Ordinal(0)] 
		[RED("MetadataForOverride")] 
		public CName MetadataForOverride
		{
			get
			{
				if (_metadataForOverride == null)
				{
					_metadataForOverride = (CName) CR2WTypeManager.Create("CName", "MetadataForOverride", cr2w, this);
				}
				return _metadataForOverride;
			}
			set
			{
				if (_metadataForOverride == value)
				{
					return;
				}
				_metadataForOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ActorName")] 
		public CName ActorName
		{
			get
			{
				if (_actorName == null)
				{
					_actorName = (CName) CR2WTypeManager.Create("CName", "ActorName", cr2w, this);
				}
				return _actorName;
			}
			set
			{
				if (_actorName == value)
				{
					return;
				}
				_actorName = value;
				PropertySet(this);
			}
		}

		public questActorOverrideEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
