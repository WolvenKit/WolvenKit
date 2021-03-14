using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitDetectionDebugFrameDataShapeEntry : CVariable
	{
		private WorldTransform _ansformWS;

		[Ordinal(0)] 
		[RED("ansformWS")] 
		public WorldTransform AnsformWS
		{
			get
			{
				if (_ansformWS == null)
				{
					_ansformWS = (WorldTransform) CR2WTypeManager.Create("WorldTransform", "ansformWS", cr2w, this);
				}
				return _ansformWS;
			}
			set
			{
				if (_ansformWS == value)
				{
					return;
				}
				_ansformWS = value;
				PropertySet(this);
			}
		}

		public gameHitDetectionDebugFrameDataShapeEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
