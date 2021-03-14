using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CurveResourceSetEntry : CVariable
	{
		private CName _name;
		private rRef<CurveSet> _curveResRef;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("curveResRef")] 
		public rRef<CurveSet> CurveResRef
		{
			get
			{
				if (_curveResRef == null)
				{
					_curveResRef = (rRef<CurveSet>) CR2WTypeManager.Create("rRef:CurveSet", "curveResRef", cr2w, this);
				}
				return _curveResRef;
			}
			set
			{
				if (_curveResRef == value)
				{
					return;
				}
				_curveResRef = value;
				PropertySet(this);
			}
		}

		public CurveResourceSetEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
