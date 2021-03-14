using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entEntityParametersStorage : ISerializable
	{
		private CArray<CHandle<entEntityParameter>> _parameters;

		[Ordinal(0)] 
		[RED("parameters")] 
		public CArray<CHandle<entEntityParameter>> Parameters
		{
			get
			{
				if (_parameters == null)
				{
					_parameters = (CArray<CHandle<entEntityParameter>>) CR2WTypeManager.Create("array:handle:entEntityParameter", "parameters", cr2w, this);
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

		public entEntityParametersStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
