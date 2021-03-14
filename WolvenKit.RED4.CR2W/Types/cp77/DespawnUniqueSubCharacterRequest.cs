using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DespawnUniqueSubCharacterRequest : gameScriptableSystemRequest
	{
		private TweakDBID _subCharacterID;

		[Ordinal(0)] 
		[RED("subCharacterID")] 
		public TweakDBID SubCharacterID
		{
			get
			{
				if (_subCharacterID == null)
				{
					_subCharacterID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "subCharacterID", cr2w, this);
				}
				return _subCharacterID;
			}
			set
			{
				if (_subCharacterID == value)
				{
					return;
				}
				_subCharacterID = value;
				PropertySet(this);
			}
		}

		public DespawnUniqueSubCharacterRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
