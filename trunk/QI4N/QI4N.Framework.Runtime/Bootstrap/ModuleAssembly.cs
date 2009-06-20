﻿namespace QI4N.Framework.Runtime
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using Bootstrap;

    [DebuggerDisplay("Name {Name}")]
    public class ModuleAssemblyImpl : ModuleAssembly
    {
        private readonly IList<EntityDeclaration> entityDeclarations = new List<EntityDeclaration>();

        private readonly string name;

        private readonly IList<ServiceDeclaration> serviceDeclarations = new List<ServiceDeclaration>();

        private readonly IList<TransientDeclaration> transientDeclarations = new List<TransientDeclaration>();

        private readonly IList<ValueDeclaration> valueDeclarations = new List<ValueDeclaration>();

        private LayerAssembly layerAssembly;

        private readonly MetaInfo metaInfo;

        public ModuleAssemblyImpl(LayerAssembly layerAssembly, string name,MetaInfo metaInfo)
        {
            this.layerAssembly = layerAssembly;
            this.name = name;
            this.metaInfo = metaInfo;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public MetaInfo MetaInfo
        {
            get
            {
                return metaInfo;
            }
        }

        public IList<TransientDeclaration> TransientDeclarations
        {
            get
            {
                return transientDeclarations;
            }
        }

        public IList<ValueDeclaration> ValueDeclarations
        {
            get
            {
                return this.valueDeclarations;
            }
        }

        public IList<ServiceDeclaration> ServiceDeclarations
        {
            get
            {
                return this.serviceDeclarations;
            }
        }

        public IList<EntityDeclaration> EntityDeclarations
        {
            get
            {
                return this.entityDeclarations;
            }
        }

        public EntityDeclaration AddEntities()
        {
            var declaration = new EntityDeclarationImpl();
            this.EntityDeclarations.Add(declaration);
            return declaration;
        }

        public ServiceDeclaration AddServices()
        {
            var declaration = new ServiceDeclarationImpl();
            this.ServiceDeclarations.Add(declaration);
            return declaration;
        }

        public TransientDeclaration AddTransients()
        {
            var declaration = new TransientDeclarationImpl();
            this.transientDeclarations.Add(declaration);
            return declaration;
        }

        public ValueDeclaration AddValues()
        {
            var declaration = new ValueDeclarationImpl();
            this.ValueDeclarations.Add(declaration);
            return declaration;
        }

        public void Visit(AssemblyVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}