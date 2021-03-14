using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraTagLimitData : IScriptable
	{
		private CBool _add;
		private wCHandle<SurveillanceCamera> _object;

		[Ordinal(0)] 
		[RED("add")] 
		public CBool Add
		{
			get
			{
				if (_add == null)
				{
					_add = (CBool) CR2WTypeManager.Create("Bool", "add", cr2w, this);
				}
				return _add;
			}
			set
			{
				if (_add == value)
				{
					return;
				}
				_add = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("object")] 
		public wCHandle<SurveillanceCamera> Object
		{
			get
			{
				if (_object == null)
				{
					_object = (wCHandle<SurveillanceCamera>) CR2WTypeManager.Create("whandle:SurveillanceCamera", "object", cr2w, this);
				}
				return _object;
			}
			set
			{
				if (_object == value)
				{
					return;
				}
				_object = value;
				PropertySet(this);
			}
		}

		public CameraTagLimitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
