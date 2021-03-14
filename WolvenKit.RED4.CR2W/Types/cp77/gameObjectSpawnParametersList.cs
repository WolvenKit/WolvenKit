using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameObjectSpawnParametersList : gameObjectSpawnParameter
	{
		private CArray<CHandle<gameObjectSpawnParameter>> _parameterList;

		[Ordinal(0)] 
		[RED("parameterList")] 
		public CArray<CHandle<gameObjectSpawnParameter>> ParameterList
		{
			get
			{
				if (_parameterList == null)
				{
					_parameterList = (CArray<CHandle<gameObjectSpawnParameter>>) CR2WTypeManager.Create("array:handle:gameObjectSpawnParameter", "parameterList", cr2w, this);
				}
				return _parameterList;
			}
			set
			{
				if (_parameterList == value)
				{
					return;
				}
				_parameterList = value;
				PropertySet(this);
			}
		}

		public gameObjectSpawnParametersList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
