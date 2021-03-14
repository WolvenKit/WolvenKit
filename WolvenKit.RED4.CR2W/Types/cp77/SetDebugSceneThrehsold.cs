using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetDebugSceneThrehsold : gameScriptableSystemRequest
	{
		private CInt32 _newThreshold;

		[Ordinal(0)] 
		[RED("newThreshold")] 
		public CInt32 NewThreshold
		{
			get
			{
				if (_newThreshold == null)
				{
					_newThreshold = (CInt32) CR2WTypeManager.Create("Int32", "newThreshold", cr2w, this);
				}
				return _newThreshold;
			}
			set
			{
				if (_newThreshold == value)
				{
					return;
				}
				_newThreshold = value;
				PropertySet(this);
			}
		}

		public SetDebugSceneThrehsold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
