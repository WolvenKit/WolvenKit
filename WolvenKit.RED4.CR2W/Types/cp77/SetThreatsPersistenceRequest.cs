using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetThreatsPersistenceRequest : AIAIEvent
	{
		private wCHandle<entEntity> _et;
		private CBool _isPersistent;

		[Ordinal(2)] 
		[RED("et")] 
		public wCHandle<entEntity> Et
		{
			get
			{
				if (_et == null)
				{
					_et = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "et", cr2w, this);
				}
				return _et;
			}
			set
			{
				if (_et == value)
				{
					return;
				}
				_et = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isPersistent")] 
		public CBool IsPersistent
		{
			get
			{
				if (_isPersistent == null)
				{
					_isPersistent = (CBool) CR2WTypeManager.Create("Bool", "isPersistent", cr2w, this);
				}
				return _isPersistent;
			}
			set
			{
				if (_isPersistent == value)
				{
					return;
				}
				_isPersistent = value;
				PropertySet(this);
			}
		}

		public SetThreatsPersistenceRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
