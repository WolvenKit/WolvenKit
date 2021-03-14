using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAnimationEventsOverrideNode : questIAudioNodeType
	{
		private CArray<questActorOverrideEntry> _perActorOverrides;
		private CName _globalMetadata;

		[Ordinal(0)] 
		[RED("perActorOverrides")] 
		public CArray<questActorOverrideEntry> PerActorOverrides
		{
			get
			{
				if (_perActorOverrides == null)
				{
					_perActorOverrides = (CArray<questActorOverrideEntry>) CR2WTypeManager.Create("array:questActorOverrideEntry", "perActorOverrides", cr2w, this);
				}
				return _perActorOverrides;
			}
			set
			{
				if (_perActorOverrides == value)
				{
					return;
				}
				_perActorOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("GlobalMetadata")] 
		public CName GlobalMetadata
		{
			get
			{
				if (_globalMetadata == null)
				{
					_globalMetadata = (CName) CR2WTypeManager.Create("CName", "GlobalMetadata", cr2w, this);
				}
				return _globalMetadata;
			}
			set
			{
				if (_globalMetadata == value)
				{
					return;
				}
				_globalMetadata = value;
				PropertySet(this);
			}
		}

		public questAnimationEventsOverrideNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
