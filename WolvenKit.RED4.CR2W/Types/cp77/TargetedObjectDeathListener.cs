using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetedObjectDeathListener : gameCustomValueStatPoolsListener
	{
		private wCHandle<SensorDevice> _lsitener;
		private wCHandle<gameObject> _lsitenTarget;

		[Ordinal(0)] 
		[RED("lsitener")] 
		public wCHandle<SensorDevice> Lsitener
		{
			get
			{
				if (_lsitener == null)
				{
					_lsitener = (wCHandle<SensorDevice>) CR2WTypeManager.Create("whandle:SensorDevice", "lsitener", cr2w, this);
				}
				return _lsitener;
			}
			set
			{
				if (_lsitener == value)
				{
					return;
				}
				_lsitener = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lsitenTarget")] 
		public wCHandle<gameObject> LsitenTarget
		{
			get
			{
				if (_lsitenTarget == null)
				{
					_lsitenTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "lsitenTarget", cr2w, this);
				}
				return _lsitenTarget;
			}
			set
			{
				if (_lsitenTarget == value)
				{
					return;
				}
				_lsitenTarget = value;
				PropertySet(this);
			}
		}

		public TargetedObjectDeathListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
