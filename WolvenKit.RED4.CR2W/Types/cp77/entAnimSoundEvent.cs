using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimSoundEvent : entSoundEvent
	{
		private CName _metadataContext;

		[Ordinal(4)] 
		[RED("metadataContext")] 
		public CName MetadataContext
		{
			get
			{
				if (_metadataContext == null)
				{
					_metadataContext = (CName) CR2WTypeManager.Create("CName", "metadataContext", cr2w, this);
				}
				return _metadataContext;
			}
			set
			{
				if (_metadataContext == value)
				{
					return;
				}
				_metadataContext = value;
				PropertySet(this);
			}
		}

		public entAnimSoundEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
