using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entContextualLookAtRemoveEvent : entLookAtRemoveEvent
	{
		private CName _contextName;

		[Ordinal(3)] 
		[RED("contextName")] 
		public CName ContextName
		{
			get
			{
				if (_contextName == null)
				{
					_contextName = (CName) CR2WTypeManager.Create("CName", "contextName", cr2w, this);
				}
				return _contextName;
			}
			set
			{
				if (_contextName == value)
				{
					return;
				}
				_contextName = value;
				PropertySet(this);
			}
		}

		public entContextualLookAtRemoveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
