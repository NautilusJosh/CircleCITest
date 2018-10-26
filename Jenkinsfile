pipeline{
    agent { 
        docker {
            image 'microsoft/dotnet' 
        }
    }
    stages {
        stage('Example'){
            steps {
                powershell 'dotnet --info'
            }
        }
    }
}