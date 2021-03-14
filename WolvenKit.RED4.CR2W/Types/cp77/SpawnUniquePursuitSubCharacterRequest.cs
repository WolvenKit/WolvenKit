using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpawnUniquePursuitSubCharacterRequest : gameScriptableSystemRequest
	{
		private TweakDBID _subCharacterID;
		private Vector4 _position;

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

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		public SpawnUniquePursuitSubCharacterRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
