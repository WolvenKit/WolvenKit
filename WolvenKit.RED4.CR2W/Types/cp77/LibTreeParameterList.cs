using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeParameterList : CVariable
	{
		private CArray<LibTreeParameter> _parameters;

		[Ordinal(0)] 
		[RED("parameters")] 
		public CArray<LibTreeParameter> Parameters
		{
			get
			{
				if (_parameters == null)
				{
					_parameters = (CArray<LibTreeParameter>) CR2WTypeManager.Create("array:LibTreeParameter", "parameters", cr2w, this);
				}
				return _parameters;
			}
			set
			{
				if (_parameters == value)
				{
					return;
				}
				_parameters = value;
				PropertySet(this);
			}
		}

		public LibTreeParameterList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
