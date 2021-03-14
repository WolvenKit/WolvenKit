using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ArcadeMachineControllerPS : ScriptableDeviceComponentPS
	{
		private CArray<redResourceReferenceScriptToken> _gameVideosPaths;

		[Ordinal(103)] 
		[RED("gameVideosPaths")] 
		public CArray<redResourceReferenceScriptToken> GameVideosPaths
		{
			get
			{
				if (_gameVideosPaths == null)
				{
					_gameVideosPaths = (CArray<redResourceReferenceScriptToken>) CR2WTypeManager.Create("array:redResourceReferenceScriptToken", "gameVideosPaths", cr2w, this);
				}
				return _gameVideosPaths;
			}
			set
			{
				if (_gameVideosPaths == value)
				{
					return;
				}
				_gameVideosPaths = value;
				PropertySet(this);
			}
		}

		public ArcadeMachineControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
