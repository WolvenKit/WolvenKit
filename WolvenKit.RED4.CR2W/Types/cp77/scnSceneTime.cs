using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneTime : CVariable
	{
		private CUInt32 _stu;

		[Ordinal(0)] 
		[RED("stu")] 
		public CUInt32 Stu
		{
			get
			{
				if (_stu == null)
				{
					_stu = (CUInt32) CR2WTypeManager.Create("Uint32", "stu", cr2w, this);
				}
				return _stu;
			}
			set
			{
				if (_stu == value)
				{
					return;
				}
				_stu = value;
				PropertySet(this);
			}
		}

		public scnSceneTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
