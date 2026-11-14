using System.Collections.Generic;
using System.Linq;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf.SharpDX;
using WolvenKit.App.Models;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// Where the components of an entity go (entity and sector previews).
/// A mesh component is placed by its localTransform relative to what its parentTransform binds it to:
/// another mesh component, a slot, a rig bone, or a component without a mesh (placeholder, collider...).
/// Bindings to components without a mesh used to be dropped, so their transforms were lost.
/// </summary>
public partial class RDTMeshViewModel
{
    private const int MaxBindingDepth = 32;

    /// <summary>
    /// The ent appearance a sector entity node shows: the one its appearanceName names,
    /// else the entity's default appearance, else the first one.
    /// </summary>
    private static List<entTemplateAppearance> SectorEntityAppearances(entEntityTemplate ent, string? nodeAppearance)
    {
        var all = ent.Appearances.Where(x => x is not null).ToList();

        if (!string.IsNullOrEmpty(nodeAppearance) &&
            all.FirstOrDefault(x => x.Name == (CName)nodeAppearance) is { } byName)
        {
            return [byName];
        }

        if (all.FirstOrDefault(x => x.Name == ent.DefaultAppearance) is { } byDefault)
        {
            return [byDefault];
        }

        return all.Count > 0 ? [all[0]] : [];
    }

    /// <summary>Placed components by name: what other components can be bound to.</summary>
    private static Dictionary<string, entIPlacedComponent> CollectPlacedComponents(IEnumerable<RedBaseClass> chunks)
    {
        var placed = new Dictionary<string, entIPlacedComponent>();
        foreach (var chunk in chunks)
        {
            if (chunk is entIPlacedComponent component && component.Name.GetResolvedText() is { Length: > 0 } name)
            {
                placed[name] = component;
            }
        }

        return placed;
    }

    /// <summary>
    /// A model bound to a component that is not drawn (no mesh: placeholder, collider, a mesh that
    /// failed to load...) takes that component's transform, and is bound to whatever that one is bound to.
    /// Models, slots and rigs stay as they are: the scene graph places models under them.
    /// </summary>
    private void ResolvePlacedParents(List<LoadableModel> models, Dictionary<string, entIPlacedComponent> placed)
    {
        var modelNames = new HashSet<string>(models.Select(m => m.Name));

        foreach (var model in models)
        {
            Matrix3D? parents = null;
            var depth = 0;

            while (model.BindName is { } bind &&
                   depth++ < MaxBindingDepth &&
                   !modelNames.Contains(bind) &&
                   !_slotSets.ContainsKey(bind) &&
                   !Rigs.ContainsKey(bind) &&
                   placed.TryGetValue(bind, out var parent))
            {
                var parentMatrix = ToSeparateMatrix(parent.LocalTransform).ToMatrix3D();
                parents = parents is { } inner ? inner * parentMatrix : parentMatrix;

                if (parent.ParentTransform?.GetValue() is entHardTransformBinding binding)
                {
                    model.BindName = binding.BindName;
                    model.SlotName = binding.SlotName;
                }
                else
                {
                    model.BindName = null;
                    model.SlotName = null;
                }
            }

            if (parents is { } matrix)
            {
                model.Transform = new MatrixTransform3D(model.Matrix.ToMatrix3D() * matrix);
            }
        }
    }

    /// <summary>
    /// Group for a model of an entity without appearances: its transform in the entity,
    /// through the models, slots and bones it is bound to.
    /// </summary>
    private MeshComponent PlacedModelGroup(LoadableModel model, List<LoadableModel> models)
    {
        var byName = new Dictionary<string, LoadableModel>();
        foreach (var m in models)
        {
            byName.TryAdd(m.Name, m);
        }

        return new MeshComponent()
        {
            Name = model.Name,
            Text = model.Name,
            WorldNodeIndex = string.Empty,
            WorldNodeDataIndices = string.Empty,
            DepotPath = model.DepotPath,
            IsRendering = model.IsEnabled, // shadow / proxy meshes stay hidden, as in entities with appearances
            Transform = new MatrixTransform3D(ModelMatrixInEntity(model, byName, 0))
        };
    }

    private Matrix3D ModelMatrixInEntity(LoadableModel model, Dictionary<string, LoadableModel> byName, int depth)
    {
        var local = model.Transform?.Value ?? model.Matrix.ToMatrix3D();
        if (depth >= MaxBindingDepth || model.BindName is not { } bind)
        {
            return local;
        }

        if (byName.TryGetValue(bind, out var parent) && !ReferenceEquals(parent, model))
        {
            return local * ModelMatrixInEntity(parent, byName, depth + 1);
        }

        return BindingMatrix(bind, model.SlotName) is { } binding ? local * binding : local;
    }

    /// <summary>
    /// Bind-pose matrix of the slot or rig bone a component is bound to, or null when the binding
    /// is neither. Slot: its offset from its bone, then the bone (or the slot component when the bone is unknown).
    /// </summary>
    private Matrix3D? BindingMatrix(string bindName, string? slotName)
    {
        if (_slotSets.TryGetValue(bindName, out var slotSet))
        {
            var slotMatrix = slotName != null && slotSet.SlotTransforms.TryGetValue(slotName, out var offset)
                ? offset
                : Matrix3D.Identity;
            var bone = slotName != null && slotSet.Slots.TryGetValue(slotName, out var boneName) ? boneName : null;

            return slotMatrix * (BoneBindMatrix(slotSet.BindName, bone) ?? slotSet.Matrix.ToMatrix3D());
        }

        return BoneBindMatrix(bindName, slotName);
    }

    /// <summary>Bone's bind pose in its rig's space, or null.</summary>
    private Matrix3D? BoneBindMatrix(string? rigName, string? boneName)
    {
        if (rigName is null || boneName is null or "None" ||
            !Rigs.TryGetValue(rigName, out var rig) ||
            rig.Bones.FirstOrDefault(b => b.Name == boneName) is not { } bone)
        {
            return null;
        }

        var matrix = Matrix3D.Identity;
        var depth = 0;
        for (RigBone? current = bone; current != null && depth++ < 512; current = current.Parent as RigBone)
        {
            matrix *= current.Matrix.ToMatrix3D();
        }

        return matrix;
    }

    /// <summary>Puts the group's own transform under the given parent matrix.</summary>
    private static void AppendTransform(GroupModel3D group, Matrix3D parent)
    {
        var own = group.Transform?.Value ?? Matrix3D.Identity;
        group.Transform = new MatrixTransform3D(own * parent);
    }
}
