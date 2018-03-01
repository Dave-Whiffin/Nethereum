﻿namespace Nethereum.Generator.Console
{
    public class ContractDeploymentCQSMessageModel
    {
        private CommonGenerators commonGenerators;

        public ContractDeploymentCQSMessageModel()
        {
            commonGenerators = new CommonGenerators();
        }

        public string GetContractDeploymentMessageTypeName(string contractName)
        {
            return $"{commonGenerators.GenerateClassName(contractName)}Deployment";
        }

        public string GetContractDeploymentMessageVariableName(string contractName)
        {
            return $"{commonGenerators.GenerateVariableName(contractName)}Deployment";
        }

    }
}