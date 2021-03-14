using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gametargetingSystemTargetFilterResult : IScriptable
	{
		private entEntityID _hitEntId;
		private wCHandle<entIComponent> _hitComponent;

		[Ordinal(0)] 
		[RED("hitEntId")] 
		public entEntityID HitEntId
		{
			get
			{
				if (_hitEntId == null)
				{
					_hitEntId = (entEntityID) CR2WTypeManager.Create("entEntityID", "hitEntId", cr2w, this);
				}
				return _hitEntId;
			}
			set
			{
				if (_hitEntId == value)
				{
					return;
				}
				_hitEntId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hitComponent")] 
		public wCHandle<entIComponent> HitComponent
		{
			get
			{
				if (_hitComponent == null)
				{
					_hitComponent = (wCHandle<entIComponent>) CR2WTypeManager.Create("whandle:entIComponent", "hitComponent", cr2w, this);
				}
				return _hitComponent;
			}
			set
			{
				if (_hitComponent == value)
				{
					return;
				}
				_hitComponent = value;
				PropertySet(this);
			}
		}

		public gametargetingSystemTargetFilterResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
