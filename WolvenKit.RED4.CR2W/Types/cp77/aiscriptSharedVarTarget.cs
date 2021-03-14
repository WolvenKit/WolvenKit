using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class aiscriptSharedVarTarget : CVariable
	{
		private LibTreeSharedVarReferenceName _varName;

		[Ordinal(0)] 
		[RED("varName")] 
		public LibTreeSharedVarReferenceName VarName
		{
			get
			{
				if (_varName == null)
				{
					_varName = (LibTreeSharedVarReferenceName) CR2WTypeManager.Create("LibTreeSharedVarReferenceName", "varName", cr2w, this);
				}
				return _varName;
			}
			set
			{
				if (_varName == value)
				{
					return;
				}
				_varName = value;
				PropertySet(this);
			}
		}

		public aiscriptSharedVarTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
