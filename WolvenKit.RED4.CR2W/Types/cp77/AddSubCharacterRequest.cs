using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddSubCharacterRequest : gameScriptableSystemRequest
	{
		private wCHandle<ScriptedPuppet> _subCharObject;

		[Ordinal(0)] 
		[RED("subCharObject")] 
		public wCHandle<ScriptedPuppet> SubCharObject
		{
			get
			{
				if (_subCharObject == null)
				{
					_subCharObject = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "subCharObject", cr2w, this);
				}
				return _subCharObject;
			}
			set
			{
				if (_subCharObject == value)
				{
					return;
				}
				_subCharObject = value;
				PropertySet(this);
			}
		}

		public AddSubCharacterRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
