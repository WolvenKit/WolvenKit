using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NameplateChangedEvent : gameScriptableSystemRequest
	{
		private entEntityID _entity;

		[Ordinal(0)] 
		[RED("entity")] 
		public entEntityID Entity
		{
			get
			{
				if (_entity == null)
				{
					_entity = (entEntityID) CR2WTypeManager.Create("entEntityID", "entity", cr2w, this);
				}
				return _entity;
			}
			set
			{
				if (_entity == value)
				{
					return;
				}
				_entity = value;
				PropertySet(this);
			}
		}

		public NameplateChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
