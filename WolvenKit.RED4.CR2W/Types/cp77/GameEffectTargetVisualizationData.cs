using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameEffectTargetVisualizationData : IScriptable
	{
		private CName _bucketName;
		private CArray<entEntityID> _forceHighlightTargets;

		[Ordinal(0)] 
		[RED("bucketName")] 
		public CName BucketName
		{
			get
			{
				if (_bucketName == null)
				{
					_bucketName = (CName) CR2WTypeManager.Create("CName", "bucketName", cr2w, this);
				}
				return _bucketName;
			}
			set
			{
				if (_bucketName == value)
				{
					return;
				}
				_bucketName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("forceHighlightTargets")] 
		public CArray<entEntityID> ForceHighlightTargets
		{
			get
			{
				if (_forceHighlightTargets == null)
				{
					_forceHighlightTargets = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "forceHighlightTargets", cr2w, this);
				}
				return _forceHighlightTargets;
			}
			set
			{
				if (_forceHighlightTargets == value)
				{
					return;
				}
				_forceHighlightTargets = value;
				PropertySet(this);
			}
		}

		public GameEffectTargetVisualizationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
