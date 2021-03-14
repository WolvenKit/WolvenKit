using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSaveSanitizationForbiddenAreaNode : worldTriggerAreaNode
	{
		private Vector4 _safeSpotOffset;

		[Ordinal(7)] 
		[RED("safeSpotOffset")] 
		public Vector4 SafeSpotOffset
		{
			get
			{
				if (_safeSpotOffset == null)
				{
					_safeSpotOffset = (Vector4) CR2WTypeManager.Create("Vector4", "safeSpotOffset", cr2w, this);
				}
				return _safeSpotOffset;
			}
			set
			{
				if (_safeSpotOffset == value)
				{
					return;
				}
				_safeSpotOffset = value;
				PropertySet(this);
			}
		}

		public worldSaveSanitizationForbiddenAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
